using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposotries
{
   public interface IUnitOfWork
    {
        GenericRepostory<Admin> GetAdminRepo();
        GenericRepostory<Category> GetCategoryRepo();
        GenericRepostory<Contact> GetContactRepo();
        GenericRepostory<Courier> GetCourierRepo();
        GenericRepostory<Feedback> GetFeedbackRepo();
        GenericRepostory<Offer> GetOfferRepo();
        GenericRepostory<Order> GetOrderRepo();
        GenericRepostory<Payment> GetPaymentRepo();
        GenericRepostory<Product> GetProductRepo();
        GenericRepostory<Store> GetStoreRepo();
        GenericRepostory<Supplier> GetSupplierRepo();
        GenericRepostory<User> GetUserRepo();
        void Save();
       
    }
}
