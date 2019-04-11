﻿using ETModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class BaseBuffHandler
{

}


public struct BuffHandlerVar
{
    public IBuffData data; // 对应的Buff数据
    public Unit source; // 来源方
    public float playSpeed;// 技能,特效等的播放速度
    public int skillLevel;//技能等级,用以处理一些数值需要跟随技能等级变动的情况
    public Dictionary<Type,IBufferValue> bufferValues; // 处理Buff的时候所需要的参数
}


public interface IBuffActionWithGetInputHandler
{
    void ActionHandle(BuffHandlerVar buffHandlerVar);
}

public interface IBuffActionWithSetOutputHandler
{
    IBufferValue[] ActionHandle(BuffHandlerVar buffHandlerVar);
}

public interface IBuffActionWithCollision
{
    void ActionHandle(BuffHandlerVar buffHandlerVar, Action<Unit> action); //这里的Unit是
}

public interface IBuffRemoveHanlder 
{
    void Remove(BuffHandlerVar buffHandlerVar);//主动中断/打断或者正常的效果移除之类,会调用该方法
}
