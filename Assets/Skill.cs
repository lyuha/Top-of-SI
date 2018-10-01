﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    public interface IPassive
    {
        float SkilledCoolTime(float cooltime);
    }

    public interface IBossSkill
    {
        void Do(ref Animator anim);
    }
}