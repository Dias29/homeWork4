﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeWork_Train
{
    public class Lokomotive
    {
        private string _nameOfLokomotive;        
        private string _typeOfLokomotive;        //Электровоз, тепловоз.
        private int _countOfAxle;                //Число оси.
        private int _countOfElectricMotors;
        private int _powerOfElectrickMotor;
        private int _powerOfDieselMotor;         //Если это тепловоз. Дизельный двигатель в одном локомотиве может быть только один.
        private int _maxSpeedOfLokomotive; 

        public void SetNameofLokomotive(string nameOfLokomotive)
        {
            _nameOfLokomotive = nameOfLokomotive;
        }

        public string GetNameOfLokomotive()
        {
            return _nameOfLokomotive;
        }

        public void SetTypeOfLokomotive(string typeOfLokomotive)
        {
            _typeOfLokomotive = typeOfLokomotive;
        }

        public string GetTypeOfLokomotive()
        {
            return _typeOfLokomotive;
        }

        public void SetCountOfAxle(int countOfAxle)
        {
            int maxCountOfAxle = 64;

            if(countOfAxle<maxCountOfAxle)
            {
                WriteLine("Превышено максимальное число оси!");
            }
            _countOfAxle = countOfAxle;
        }

        public int GetCountOfAxle()
        {
            return _countOfAxle;
        }

        public void SetCountOfElectricMotors(int countOfElectricMotors)
        {
            _countOfElectricMotors = countOfElectricMotors;
        }

        public int GetCountOfElectricMotors()
        {
            return _countOfElectricMotors;
        }

        public void SetPowerOfElectricMotor(int powerOfElectricMotor)
        {
            _powerOfElectrickMotor = powerOfElectricMotor;
        }

        public int GetPowerOfElectricMotor()
        {
            return _powerOfElectrickMotor;
        }

        public void SetPowerOfDieselMotor(int powerOfdieselMotor)
        {
            _powerOfDieselMotor = powerOfdieselMotor;
        }

        public void SetMaxSpeedOfLokomotive(int maxSpeedOfLokomotive)
        {
            _maxSpeedOfLokomotive = maxSpeedOfLokomotive;
        }

        public int GetMaxSpeedOfLokomotive()
        {
            return _maxSpeedOfLokomotive;
        }

        public void EnhancePower(ref int currentPower)
        {
            currentPower = currentPower + GetPowerOfElectricMotor();
        }
    }
}
