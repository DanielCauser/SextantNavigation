using System;
using System.Reactive;
using System.Reactive.Linq;
using ReactiveUI;
using Sextant;

namespace SextantNavigation
{
	public class MenuViewModel : ReactiveObject, INavigable, IViewModel
    {
		public MenuViewModel()
		{
		}

        public string? Id => "MenuViewModel";

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

