﻿using System;

namespace Zeus.Model
{
    public interface ICreationAudited
    {
        string F_Id { get; set; }
        string F_CreatorUserId { get; set; }
        DateTime? F_CreatorTime { get; set; }
    }
}