using System.Reflection;
using AtomUI.Controls;

namespace AtomUI.Icons.IconPark;

public class IconParkIconProvider : IconProvider<IconParkIconKind>
{
    public IconParkIconProvider() { }
    
    public IconParkIconProvider(IconParkIconKind kind) : base(kind) { }
    
    
    protected override Type GetTypeForKind(IconParkIconKind kind)
    {
        var typeName = $"AtomUI.Icons.IconPark.{kind.ToString()}";
        
        var type = Type.GetType(typeName) 
                   ?? Assembly.GetExecutingAssembly().GetType(typeName);
        if (type == null)
        {
            throw new InvalidOperationException($"Type {typeName} does not exist");
        }
        return type;
    }
}