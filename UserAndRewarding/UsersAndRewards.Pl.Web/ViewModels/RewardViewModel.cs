﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UsersAndRewards.Shared;

namespace UsersAndRewards.Pl.Web.ViewModels
{
    public class RewardViewModel
    {
        public int RewardId { get; set; }

        public string Title { get; set; }

        public bool IsChecked { get; set; }

        public static RewardViewModel ToModel(
            Reward reward,
            bool isChecked)
        {
            var model = new RewardViewModel();
            model.RewardId = reward.RewardId;
            model.Title = reward.Title;
            model.IsChecked = isChecked;

            return model;
        }
    }
}