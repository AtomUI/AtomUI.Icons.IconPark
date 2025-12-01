using Avalonia;
using MaterialGallery.Workspace.Views;

namespace IconParkGallery;

public partial class BaseGalleryApplication : Application
{
    protected WorkspaceWindow CreateWorkspaceWindow()
    {
        return new WorkspaceWindow();
    }

    public override void RegisterServices()
    {
        base.RegisterServices();
    }
}