﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETModel
{
    public class PVPComponent : Component
    {
        public List<Unit> red;//红方
        public List<Unit> blue;//蓝方

        public enum StateType
        {
            Ready,
            InBattle,
            redWin,
            blueWin
        }

        public void SetDie(long id)
        {

            if (red.Find((unit) => unit.Id == id) != null)
            {
                foreach (var v in red)
                {
                    UnitStateComponent unitStateComponent = v.GetComponent<UnitStateComponent>();
                    Property_Die property_Die = unitStateComponent.GetCurrState<Property_Die>();
                    if (!property_Die.Get())
                    {
                        return;
                    }
                }
                //TODO: 宣布蓝方胜利

                return;
            }

            if (blue.Find((unit) => unit.Id == id) != null)
            {
                foreach (var v in blue)
                {
                    UnitStateComponent unitStateComponent = v.GetComponent<UnitStateComponent>();
                    Property_Die property_Die = unitStateComponent.GetCurrState<Property_Die>();
                    if (!property_Die.Get())
                    {
                        return;
                    }
                }
                //TODO: 宣布红方胜利

                return;
            }
        }
    }
}
