using Xamarin.Forms;
using XF_HeyBook.Models;

namespace XF_Heybook.DataTemplates
{
    public class BookItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate WithOfferInBookItemTemplate { get; set; }
        public DataTemplate NoOfferInBookItemTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((Book)item).InOffer ? WithOfferInBookItemTemplate : NoOfferInBookItemTemplate;
        }
    }
}
