
using System.Threading.Tasks;

namespace Project.ViewModel
{
    public class Page1ViewModel : BaseViewModel
    {
        public Page1ViewModel(CardDataModel cardDataModel)
        {
            Item = cardDataModel;
        }

        private CardDataModel _item;
        public CardDataModel Item
        {
            get => _item;
            set { SetProperty(ref _item, value); }
        }
        
    }
}
