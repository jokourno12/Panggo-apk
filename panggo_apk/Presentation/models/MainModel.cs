namespace panggo_apk.Presentation;

public partial record MainModel
{
    private INavigator _navigator;

    public MainModel(
        IStringLocalizer localizer,
        IOptions<AppConfig> appInfo,
        INavigator navigator)
    {
        _navigator = navigator;
        Title = "Panggo";
    }

    public string? Title { get; }

    public IState<string> Name => State<string>.Value(this, () => string.Empty);

    public async Task GoToSecond()
    {
        var name = await Name;
        await _navigator.NavigateViewModelAsync<SecondModel>(this, data: new Entity(name!));
    }

    public async Task GoToHomePage()
    {
        await _navigator.NavigateViewModelAsync<HomeModel>(this);
    }

    public async Task GoToSearchPage()
    {
        await _navigator.NavigateViewModelAsync<SearchModel>(this);
    }

    public async Task GoToMessagePage()
    {
        await _navigator.NavigateViewModelAsync<MessageModel>(this);
    }

    public async Task GoToProfilePage()
    {
        await _navigator.NavigateViewModelAsync<ProfileModel>(this);
    }

}
