﻿using ETModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
[Serializable]
public struct Buff_CostHP_MP :   IBuffData
{
    public float costHp;
    public float costMp;
    public float costHpInPct;
    public float costMpInPct;

    public float growthPct;// 随技能等级的成长值 ,这里是在基础的消耗上*一个百分比

    public string GetBuffIdType()
    {
        return BuffIdType.CostHPMP;
    }
}
