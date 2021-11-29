using Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposotries
{
    public class UnitOfWork: IUnitOfWork
    {
        Project_Context Context;
        GenericRepostory<Admin> AdminRepo;
        GenericRepostory<Category> CategoryRepo;
        GenericRepostory<Contact> ContactRepo;
        GenericRepostory<Courier> CourierRepo;
        GenericRepostory<Feedback> FeedbackRepo;
        GenericRepostory<Offer> OfferRepo;
        GenericRepostory<Order> OrderRepo;
        GenericRepostory<Payment> PaymentRepo;
        GenericRepostory<Product> ProductRepo;
        GenericRepostory<Store> StoreRepo;
        GenericRepostory<Supplier> SupplierRepo;
        GenericRepostory<User> UserRepo;
        public UnitOfWork(  Project_Context context , GenericRepostory<Admin> adminRepo,
                            GenericRepostory<Category> categoryRepo , GenericRepostory<Contact> contactRepo,
                            GenericRepostory<Courier> courierRepo , GenericRepostory<Feedback> feedbackRepo,
                            GenericRepostory<Offer> offerRepo , GenericRepostory<Order> orderRepo,
                            GenericRepostory<Payment> paymentRepo , GenericRepostory<Product> productRepo,
                            GenericRepostory<Store> storeRepo , GenericRepostory<Supplier> supplierRepo,
                            GenericRepostory<User> userRepo){


            Context = context;
            AdminRepo = adminRepo;
            CategoryRepo = categoryRepo;
            ContactRepo = contactRepo;
            CourierRepo = courierRepo;
            FeedbackRepo = feedbackRepo;
            OfferRepo = offerRepo;
            OrderRepo = orderRepo;
            PaymentRepo = paymentRepo;
            ProductRepo = productRepo;
            StoreRepo = storeRepo;
            SupplierRepo = supplierRepo;
            UserRepo = userRepo;
        }

        public GenericRepostory<Admin> GetAdminRepo()
        {
            return AdminRepo;

        }
        public GenericRepostory<Category> GetCategoryRepo()
        {
            return CategoryRepo;

        }
        public GenericRepostory<Contact> GetContactRepo()
        {
            return ContactRepo;

        }
        public GenericRepostory<Courier> GetCourierRepo()
        {
            return CourierRepo;

        }
        public GenericRepostory<Feedback> GetFeedbackRepo()
        {
            return FeedbackRepo;

        }
        public GenericRepostory<Offer> GetOfferRepo()
        {
            return OfferRepo;

        }
        public GenericRepostory<Order> GetOrderRepo()
        {
            return OrderRepo;

        }
        public GenericRepostory<Payment> GetPaymentRepo()
        {
            return PaymentRepo;

        }
        public GenericRepostory<Product> GetProductRepo()
        {
            return ProductRepo;

        }
        public GenericRepostory<Store> GetStoreRepo()
        {
            return StoreRepo;

        }
        public GenericRepostory<Supplier> GetSupplierRepo()
        {
            return SupplierRepo;

        }
        public GenericRepostory<User> GetUserRepo()
        {
            return UserRepo;

        }

        public async void Save()
        {
            await Context.SaveChangesAsync();
        }
    }
}
