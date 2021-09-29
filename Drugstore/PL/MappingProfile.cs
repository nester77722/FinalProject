    using AutoMapper;
using BLL.Models;
using DAL.Entities;
using PL.ViewModels;

namespace PL
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Store, StoreModel>();
            CreateMap<StoreModel, StoreViewModel>();

            CreateMap<Product, ProductModel>();
            CreateMap<ProductModel, ProductViewModel>();

            CreateMap<StoreResponse, StoreResponseModel>();
            CreateMap<StoreResponseModel, StoreResponseViewModel>();

            CreateMap<ProductResponse, ProductResponseModel>();
            CreateMap<ProductResponseModel, ProductResponseViewModel>();

            CreateMap<ProductImage, ProductImageModel>();
            CreateMap<ProductImageModel, ProductImageViewModel>();
        }
    }
}
