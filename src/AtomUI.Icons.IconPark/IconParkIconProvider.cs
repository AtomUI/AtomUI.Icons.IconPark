using System.Diagnostics.CodeAnalysis;
using AtomUI.Controls;

namespace AtomUI.Icons.IconPark;

public partial class IconParkIconProvider : IconProvider<IconParkIconKind>
{
    public IconParkIconProvider() { }
    
    public IconParkIconProvider(IconParkIconKind kind) : base(kind) { }

    protected override Icon GetIcon(IconParkIconKind kind)
    {
        try
        {
            return CreateIcon(kind);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Create icon {kind} failed", ex);
        }
    }

    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    protected override Type GetTypeForKind(IconParkIconKind kind)
    {
        return GetIconType(kind);
    }
}
