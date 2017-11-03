using Moq;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStoreDomain.Abstruct;
using BookStoreDomain.Entities;

namespace BookStoreWebUI.InfraStructure
{
    public class NinjectDependencyResolver : IDependencyResolver

    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }



        private void AddBindings()
        {

           Mock <IBookRepository> mock = new Mock<IBookRepository>();
            mock.Setup(b => b.Books).Returns(
                        new List<Book> {
                            new Book { Title = "sql",},
                            new Book { Title = "web",},
                            new Book { Title = "Aspnet",},
                            new Book { Title = "PhP",}
                        }
                );
            kernel.Bind<IBookRepository>().ToConstant(mock.Object);

         
        }
    }
}