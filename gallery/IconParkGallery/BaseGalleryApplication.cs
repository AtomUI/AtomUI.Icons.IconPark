using Avalonia;
using IconParkGallery.Workspace.Views;

namespace IconParkGallery;

public abstract partial class BaseGalleryApplication : Application
{
    protected WorkspaceWindow CreateWorkspaceWindow()
    {
        return new WorkspaceWindow();
    }
}
