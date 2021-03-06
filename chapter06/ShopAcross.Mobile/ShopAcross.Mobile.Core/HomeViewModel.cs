﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ShopAcross.Mobile.Core
{

    public class HomeViewModel: BaseBindableObject
{
    public HomeViewModel()
    {
        RecentProducts = new ObservableCollection<ProductViewModel>(GetRecentProducts());
    }

    public ObservableCollection<ProductViewModel> RecentProducts { get; } = new ObservableCollection<ProductViewModel>();

    public IEnumerable<ProductViewModel> GetRecentProducts()
    {
        yield return new ProductViewModel {
            Title = "First Item",
            IsHtml = true,
            Description = "<b/>Here</b> is some <u>HTML</u>;",
            Image = "https://picsum.photos/800?image=0" };

            //... Removed for brevity
            yield return new ProductViewModel { Title = "Second Item", Description = "Second item short description", Image = "https://picsum.photos/800?image=1" };
            yield return new ProductViewModel { Title = "Third Item", Description = "Third Item short description.", Image = "https://picsum.photos/800?image=2" };
            yield return new ProductViewModel { Title = "Fourth Item", Description = "Fourth Item short description.", Image = "https://picsum.photos/800?image=3" };
            yield return new ProductViewModel { Title = "Fifth Item", Description = "Fifth Item short description.", Image = "https://picsum.photos/800?image=4" };
            yield return new ProductViewModel { Title = "Sixth Item", Description = "Sixth Item short description.", Image = "https://picsum.photos/800?image=5" };
            yield return new ProductViewModel { Title = "Seventh Item", Description = "Seventh Item short description.", Image = "https://picsum.photos/800?image=6" };
        }
}


    /*
     *             yield return new ProductViewModel { Title = "First Item", Description = "First Item short description", Image = "https://picsum.photos/800?image=0" };
            yield return new ProductViewModel { Title = "Second Item", Description = "<b>Here</b> is some <u>HTML</u>", Image = "https://picsum.photos/800?image=1" };
            yield return new ProductViewModel { Title = "Third Item", Description = "Third Item short description.", Image = "https://picsum.photos/800?image=2" };
            yield return new ProductViewModel { Title = "Fourth Item", Description = "Fourth Item short description.", Image = "https://picsum.photos/800?image=3" };
            yield return new ProductViewModel { Title = "Fifth Item", Description = "Fifth Item short description.", Image = "https://picsum.photos/800?image=4" };
            yield return new ProductViewModel { Title = "Sixth Item", Description = "Sixth Item short description.", Image = "https://picsum.photos/800?image=5" };
            yield return new ProductViewModel { Title = "Seventh Item", Description = "Seventh Item short description.", Image = "https://picsum.photos/800?image=6" };
     */
}
