using System;
using System.Windows.Forms;
using Patterns.AbstractFactory;
using Patterns.Adapter;
using Patterns.BehaviorPattern.Duck;
using Patterns.Command;
using Patterns.Command.Devices;
using Patterns.Composite;
using Patterns.Decorator;
using Patterns.Observer;
using Patterns.Singleton;
using Patterns.State;
using Patterns.TemplateMethod;

namespace Patterns
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            RunObserverPatternExample();

            RunDecoratorPatternExample();

            RunAbstractFactoryExample();

            RunSingletonExample();

            RunCommandExample();

            RunAdapterExample();

            RunTemplateMethodExample();

            RunCompositeExample();

            RunStateExample();
        }

        private void RunStateExample()
        {
            var gumBallMachine = new GumballMachine(5);
            
            gumBallMachine.InsertQuarter();
            gumBallMachine.TurnCrank();
        }


        private void RunCompositeExample()
        {
            MenuComponent menuFirst = new Patterns.Composite.Menu();

            menuFirst.Add(new Patterns.Composite.MenuItem(true));
            menuFirst.Add(new Patterns.Composite.MenuItem(false));

            MenuComponent menuSecond = new Patterns.Composite.Menu();

            menuSecond.Add(new Patterns.Composite.MenuItem(false));
            menuSecond.Add(new Patterns.Composite.MenuItem(false));

            MenuComponent allMenus = new Patterns.Composite.Menu();

            allMenus.Add(menuFirst);
            allMenus.Add(menuSecond);


            listBox1.Items.Add("RunCompositeExample");
            listBox1.Items.Add("Info Abou Menu: " + allMenus.GetInfo());
        }


        private void RunTemplateMethodExample()
        {
            Coffee coffee = new Coffee();
            coffee.PrepareBeverage();

            Tea tea = new Tea();
            tea.PrepareBeverage();
        }


        private void RunAdapterExample()
        {
            Duck rubberDuck = new RubberDuck();
            ITurkey wildTurkey = new WildTurkey();

            TurkeyToDuckAdapter turkey = new TurkeyToDuckAdapter(wildTurkey);

            turkey.PerformFly();
            turkey.PerformQuack();
        }


        private void RunCommandExample()
        {
            RemoteControl remoteControl = new RemoteControl();

            var light = new Light();
            var lightCommand = new LightOnCommand(light);

            var fan = new Fan();
            var fanCommand = new FanCommand(fan);

            remoteControl.SetCommand(lightCommand);
            remoteControl.Perform();

            remoteControl.SetCommand(fanCommand);
            remoteControl.Perform();
        }


        private void RunSingletonExample()
        {
            ChocolateBoiler boiler = ChocolateBoiler.GetChocolateBoiler();

            boiler.SomethingMethod();
            boiler.SomethingAnotherMethod();
        }


        private void RunAbstractFactoryExample()
        {
            NYPizzaStore nyPizzaStore = new NYPizzaStore();
            nyPizzaStore.OrderPizza("cheese");

            ChicagoPizzaStore chicagoPizzaStore = new ChicagoPizzaStore();
            chicagoPizzaStore.OrderPizza("cheese");
        }


        private void RunDecoratorPatternExample()
        {
            Beverage beverage = new Espresso();

            beverage = new Whip(beverage).GetBeverage;
            beverage = new Mocha(beverage).GetBeverage;

            DisplayInfoAboutBeverageInListBox(beverage);
        }

        private void DisplayInfoAboutBeverageInListBox(Beverage beverage)
        {
            listBox1.Items.Add(beverage.Description + "; Cost:" + beverage.Cost());
        }


        private void RunObserverPatternExample()
        {
            var weather = new WeatherData();
            var observers = new IWeatherObserver[2];

            observers[0] = new CurrentWeatherDisplay();
            observers[1] = new ForecastDisplay();

            foreach (IWeatherObserver weatherObserver in observers)
            {
                weather.WeatherNotification += weatherObserver.UpdateWeatherDate;
            }

            weather.ChangeWeatherData();
            DisplayHumidityInListBox(observers);

            weather.ChangeWeatherData();
            DisplayHumidityInListBox(observers);
        }

        private void DisplayHumidityInListBox(IWeatherObserver[] observers)
        {
            listBox1.Items.Add(observers[0].GetType().Name + ": humidity = " +
                               (observers[0] as CurrentWeatherDisplay).Humidity);

            listBox1.Items.Add(observers[1].GetType().Name + ": humidity = " +
                               (observers[1] as ForecastDisplay).Humidity);
        }
    }
}