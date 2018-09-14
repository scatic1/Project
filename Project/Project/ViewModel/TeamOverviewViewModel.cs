using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ViewModel
{
    public class TeamOverviewViewModel : BaseViewModel
    {
        public ActiveNowViewModel activeNowViewModel = new ActiveNowViewModel();
        public UsedAllreadyViewModel usedAllreadyViewModel = new UsedAllreadyViewModel();

        public IList<CardDataModel> listOfActive = new List<CardDataModel>();
        public IList<CardDataModel> listOfUsed = new List<CardDataModel>();

        private CardDataModel _random11;
        public CardDataModel random11
        {
            get => _random11;
            set { SetProperty(ref _random11, value); }
        }
        private CardDataModel _random12;
        public CardDataModel random12
        {
            get => _random12;
            set { SetProperty(ref _random12, value); }
        }
        private CardDataModel _random13;
        public CardDataModel random13
        {
            get => _random13;
            set { SetProperty(ref _random13, value); }
        }
        private CardDataModel _random21;
        public CardDataModel random21
        {
            get => _random21;
            set { SetProperty(ref _random21, value); }
        }
        private CardDataModel _random22;
        public CardDataModel random22
        {
            get => _random22;
            set { SetProperty(ref _random22, value); }
        }
        private CardDataModel _random23;
        public CardDataModel random23
        {
            get => _random23;
            set
            {
                SetProperty(ref _random23, value);
            }
        }

        public TeamOverviewViewModel()
        {
            listOfActive = activeNowViewModel.ActiveNow;
            listOfUsed = usedAllreadyViewModel.UsedAllready;
            random11 = listOfActive[0];
            random12 = listOfActive[1];
            random13 = listOfActive[2];
            random21 = listOfUsed[0];
            random22 = listOfUsed[1];
            random23 = listOfUsed[2];
        }
    }
}
