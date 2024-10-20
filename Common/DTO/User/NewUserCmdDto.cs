﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO.User;

public sealed record NewUserCmdDto(string Email, string Password, string Name, string Surname, string? PhoneNumber,
  DateTime? BirthDate, DateTime? StartJobDate, string? TransactionUser, int Status);