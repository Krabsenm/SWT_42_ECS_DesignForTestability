﻿namespace ECS
{
    public interface IHeater
    {
        bool RunSelfTest();
        void TurnOff();
        void TurnOn();
    }
}