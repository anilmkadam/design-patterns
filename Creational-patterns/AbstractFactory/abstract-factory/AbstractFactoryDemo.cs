using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class CPU { }    //CPU class

    public class EmberCPU : CPU { }    //EmberCPU class

    public class EnginolaCPU : CPU { }  //EnginolaCPU class

    //class MMU
    public abstract class MMU { }

    //class EmberMMu
    public class EmberMMU : MMU { }

    //EnginolaMMU class
    public class EnginolaMMU : MMU { }

    //helps to decide which architecture should return.
    public enum Architecture
    {
        Ember,
        Enginola
    }

    //EmberFactory class which intance of Ember
    //with all configuration
    public class EmberToolkit : AbstractFactoryDemo
    {
        override public CPU CreateCPU()
        {
            return new EmberCPU();
        }
        override public MMU CreateMMU()
        {
            return new EmberMMU();
        }
    }

    //EnginolaFactory class which intance of Enginola
    //with all configuration
    public class EnginolaToolkit : AbstractFactoryDemo
    {
        override public CPU CreateCPU()
        {
            return new EnginolaCPU();
        }
        override public MMU CreateMMU()
        {
            return new EnginolaMMU();
        }
    }

    //Abstarct Factory which drive the code
    //and return specified instance, which end user wants
    public abstract class AbstractFactoryDemo
    {
        // Returns a concrete factory object that is an instance of the
        // concrete factory class appropriate for the given architecture.
        public static AbstractFactoryDemo GetAbstractFactory(Architecture architecture)
        {
            AbstractFactoryDemo factory = null;
            switch (architecture)
            {
                //Ember toolkit configuration instance
                case Architecture.Ember:
                    factory = new EmberToolkit();
                    break;
                //Enginola toolkit configuration instance
                case Architecture.Enginola:
                    factory = new EnginolaToolkit();
                    break;
            }
            return factory;
        }
        public abstract CPU CreateCPU();    //Return CPU instance
        public abstract MMU CreateMMU();    //Return MMU instanse
    }
}
