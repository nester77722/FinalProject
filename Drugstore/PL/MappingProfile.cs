    using AutoMapper;
using BLL.Models;
using DAL.Entities;
using DAL.Entities.Order;
using PL.ViewModels;
using PL.ViewModels.Order;

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

            CreateMap<Order, OrderModel>();
            CreateMap<OrderModel, OrderViewModel>();

            CreateMap<OrderItem, OrderItemModel>();
            CreateMap<OrderItemModel, OrderItemViewModel>();

            CreateMap<OrderResponse, OrderResponseModel>();
            CreateMap<OrderResponseModel, OrderResponseViewModel>();

            CreateMap<Stock, StockModel>();
            CreateMap<StockModel, StockViewModel>();
        }
    }
}
