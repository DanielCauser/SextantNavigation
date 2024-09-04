using System;
using System.Reactive;
using System.Reactive.Linq;
using ReactiveUI;
using Sextant;

namespace SextantNavigation
{
	public class LogedInViewModel : ReactiveObject, INavigable, IViewModel
    {
		public LogedInViewModel()
		{
		}

        public string? Id => "LogedInViewModel";

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

