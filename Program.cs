using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
using MarsRover.Core;
using MarsRover.Service;

namespace MarsRover
{
    public class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.Kernel.Resolver.AddSubResolver(new CollectionResolver(container.Kernel));

            container.Register(Component.For<IMovement>().ImplementedBy<ToForwardAction>());
            container.Register(Component.For<IMovement>().ImplementedBy<ToLeftAction>());
            container.Register(Component.For<IMovement>().ImplementedBy<ToRightAction>());
            container.Register(Component.For(typeof(MovementService)));

            new App(container.Resolve<MovementService>()).Start();
        }
    }
}
