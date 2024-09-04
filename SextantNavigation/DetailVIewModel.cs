using System;
using System.Reactive;
using System.Reactive.Linq;
using ReactiveUI;
using Sextant;

namespace SextantNavigation
{
	public class DetailVIewModel : ReactiveObject, INavigable, IViewModel
    {
		public DetailVIewModel()
		{
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

