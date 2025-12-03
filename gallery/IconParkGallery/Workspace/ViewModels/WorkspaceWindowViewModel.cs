using IconParkGallery.Models;
using ReactiveUI;

namespace IconParkGallery.Workspace.ViewModels;

public class WorkspaceWindowViewModel : ReactiveObject, IScreen
{
    public RoutingState Router { get; } = new RoutingState();
    
    private List<string>? _categories;

    public List<string>? Categories
    {
        get => _categories;
        set => this.RaiseAndSetIfChanged(ref _categories, value);
    }
    
    private IconMetaInfoRepository? _iconInfoRepository;

    public IconMetaInfoRepository? IconInfoRepository
    {
        get => _iconInfoRepository;
        set => this.RaiseAndSetIfChanged(ref _iconInfoRepository, value);
    }
    
    public WorkspaceWindowViewModel()
    {
    }
}