﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicStore.ViewModels
{
    /// <summary>
    /// 用户信息视图模型
    /// </summary>
    public class MyViewModel
    {
        [Display(Name = "收件人姓名")]
        [Required(ErrorMessage = "收件人姓名不能为空")]
        public string Name { get; set; }

        [Display(Name = "性别")]
        [Required(ErrorMessage = "用户名不能为空")]
        public bool Sex { get; set; }

        [Display(Name = "收货地址")]
        [Required(ErrorMessage = "收货地址不能为空")]
        public string Address { get; set; }

        [Display(Name = "收件人电话")]
        [Required(ErrorMessage = "收件人电话不能为空")]
        public string MobilNumber { get; set; }

        [Display(Name = "出生日期")]
        [Required(ErrorMessage = "出生日期")]
        public string Birthday { get; set; }

        [Display(Name = "头像")]
        [DataType(DataType.Upload)]
        public HttpPostedFileBase Avarda { get; set; }
    }
}