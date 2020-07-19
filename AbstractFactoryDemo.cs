using System;

namespace AbstractFactory {
    abstract class CPU {}    //CPU class

    class EmberCPU : CPU {}    //EmberCPU class

    class EnginolaCPU : CPU {}  //EnginolaCPU class

    //class MMU
    abstract class MMU {}

    //class EmberMMu
    class EmberMMU : MMU {}

    //EnginolaMMU class
    class EnginolaMMU : MMU {}

    //helps to decide which architecture should return.
    enum Architecture {
        Ember,
        Enginola
    }

    //EmberFactory class which intance of Ember
    //with all configuration
    class EmberToolkit : AbstractFactory
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
    class EnginolaToolkit  : AbstractFactory
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
    abstract class AbstractFactory 
    {
        // Returns a concrete factory object that is an instance of the
        // concrete factory class appropriate for the given architecture.
        static AbstractFactory GetAbstractFactory(Architecture architecture) 
        {
            AbstractFactory factory = null;
            switch(architecture) 
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