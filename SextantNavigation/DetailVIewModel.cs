using System;
using System.Reactive;
using System.Reactive.Linq;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Sextant;
using Splat;

namespace SextantNavigation
{
	public class DetailVIewModel : ReactiveObject, INavigable, IViewModel
    {
        public ReactiveCommand<Unit, Unit> BackToLoginCommand { get; }

        public DetailVIewModel()
		{
            BackToLoginCommand = ReactiveCommand.Create(() =>
            {
                Locator.Current.GetService<IViewStackService>().PushPage<MainViewModel>(resetStack: true).Subscribe();
            });

        }

        public string? Id => "DetailVIewModel";

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

