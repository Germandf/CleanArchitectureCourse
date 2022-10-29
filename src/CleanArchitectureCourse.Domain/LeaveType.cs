﻿using CleanArchitectureCourse.Domain.Common;

namespace CleanArchitectureCourse.Domain;

public class LeaveType : BaseDomainEntity
{
    public string Name { get; set; } = "";
    public int DefaultDays { get; set; }
}
