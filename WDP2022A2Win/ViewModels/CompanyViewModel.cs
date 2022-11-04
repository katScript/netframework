
namespace WDP2022A2Win.ViewModels
{
    public class CompanyViewModels
    {
        public int? Id { get; set; } = null;
        public string CompanyName { get; set; } = "";
        public string Summary { get; set; } = "";
        public string AnchorLink { get; set; } = "";
        public int Like { get; set; }
        public bool CanIncreaseLike { get; set; } = true;
        public IFormFile? Image { get; set; } = null;
    }
}