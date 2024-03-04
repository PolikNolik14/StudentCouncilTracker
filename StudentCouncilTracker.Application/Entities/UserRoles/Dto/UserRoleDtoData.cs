﻿using StudentCouncilTracker.Application.DynamicFields;
using StudentCouncilTracker.Application.DynamicFields.Attributes;
using StudentCouncilTracker.Application.DynamicFields.Enums;
using StudentCouncilTracker.Application.Entities.Base.Dto;
using StudentCouncilTracker.Application.Entities.Interfaces.Haves;

namespace StudentCouncilTracker.Application.Entities.UserRoles.Dto;

public class UserRoleDtoData : EntityDtoData, IHaveId
{
    public int Id { get; set; }

    [DynamicField(DynamicFieldType.Textbox)]
    public DynamicFieldValue<string> Name { get; set; } = null!;
}