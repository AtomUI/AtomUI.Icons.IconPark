using System.Diagnostics;
using System.Reflection;
using System.Collections.Concurrent;
using System.Linq.Expressions;
using AtomUI.Controls;

namespace AtomUI.Icons.IconPark;

public class IconParkIconProvider : IconProvider<IconParkIconKind>
{
    private static readonly ConcurrentDictionary<IconParkIconKind, Type> TypeCache = new();
    private static readonly ConcurrentDictionary<IconParkIconKind, Func<Icon>> CreatorCache = new();
    private static readonly ConcurrentDictionary<Type, Func<Icon>> TypeToCreator = new();
    private static readonly Assembly TargetAssembly = Assembly.GetExecutingAssembly();
    
    public IconParkIconProvider() { }
    
    public IconParkIconProvider(IconParkIconKind kind) : base(kind) { }
    
    protected override Icon GetIcon(IconParkIconKind kind)
    {
        try
        {
            var creator = CreatorCache.GetOrAdd(kind, k =>
            {
                var type = TypeCache.GetOrAdd(k, GetTypeForKind);
                return TypeToCreator.GetOrAdd(type, CreateFactory);
            });
            
            var icon = creator();
            Debug.Assert(icon != null);
            return icon;
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"create icon {kind} failed", ex);
        }
    }
    
    private static Type GetTypeForKind(IconParkIconKind kind)
    {
        var typeName = $"AtomUI.Icons.IconPark.{kind}";
        
        var type = Type.GetType(typeName);
        if (type != null)
        {
            return type;
        }
        
        type = TargetAssembly.GetType(typeName);
        if (type == null)
        {
            throw new InvalidOperationException($"{typeName} not exist");
        }
        
        return type;
    }
    
    private static Func<Icon> CreateFactory(Type type)
    {
        try
        {
            var constructor = type.GetConstructor(Type.EmptyTypes);
            if (constructor == null)
            {
                throw new InvalidOperationException($"No parameterless constructor found for {type.Name}");
            }
            var newExpr = Expression.New(constructor);
            var lambda = Expression.Lambda<Func<Icon>>(newExpr);
            return lambda.Compile();
        }
        catch (Exception)
        {
            return () => (Icon)Activator.CreateInstance(type)!;
        }
    }
}