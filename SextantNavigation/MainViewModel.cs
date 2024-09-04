using System;
using System.Reactive;
using System.Reactive.Linq;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Sextant;
using Splat;

namespace SextantNavigation
{
	public class MainViewModel : ReactiveObject, INavigable, IViewModel
    {
		public MainViewModel()
		{
            LoginCommand = ReactiveCommand.Create(() =>
            {
                Locator.Current.GetService<IViewStackService>().PushPage<LogedInViewModel>(resetStack: true).Subscribe();
            });
		}

        public ReactiveCommand<Unit, Unit> LoginCommand { get; }

        public string? Id => "MainViewModel";

        public IObservable<Unit> WhenNavigatedFrom(INavigationParameter parameter)
        {
            return Observable.Empty<Unit>();
        }

        public IObservable<Unit> WhenNavigatedTo(INavigationParameter parameter)
        {
            return Observable.Empty<Unit>();
        }

        public IObservable<Unit> WhenNavigatingTo(INavigationParameter parameter)
        {
            return Observable.Empty<Unit>();
        }
    }
}

