using UnityEngine;
public class MediatorExecutor : MonoBehaviour
{
    //Arabulucu modelinin C # kodundaki en popüler kullanımı, bir uygulamanın GUI bileşenleri arasındaki iletişimi kolaylaştırmaktır.
    //Arabulucunun eşanlamlısı, MVC modelinin Denetleyici kısmıdır.

    //The most popular usage of the Mediator pattern in C# code is facilitating communications between GUI components of an app.
    //The synonym of the Mediator is the Controller part of MVC pattern.

    private void Start()
    {
        Component1 component1 = new Component1();
        Component2 component2 = new Component2();
        new ConcreteMediator(component1, component2);

        Debug.Log("Client triggets operation A.");
        component1.DoA();



        Debug.Log("Client triggers operation D.");
        component2.DoD();
    }
}