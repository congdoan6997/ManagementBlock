using ManagementBlock.Application.ViewModels;
using System.Collections.Generic;

namespace ManagementBlock.Application.Interfaces
{
    public interface IProductService
    {
        ProductViewModel Add(ProductViewModel productViewModel);

        void Update(ProductViewModel productViewModel);

        void Delete(int id);

        List<ProductViewModel> GetAll();

        List<ProductViewModel> GetAll(string keyword);

        //List<ProductViewModel> GetAllByParentId(int parentId);

        ProductViewModel GetById(int id);

        //void UpdateParentId(int sourceId, int targetId, Dictionary<int, int> items);
        void ReOrder(int sourceId, int targetId);

        //List<ProductViewModel> GetHomeCategories(int top);

        void Save();
    }
}
