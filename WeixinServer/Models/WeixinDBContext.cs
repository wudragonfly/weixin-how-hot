﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace WeixinServer
{
    public class WeixinDBContext : DbContext
    {
        public WeixinDBContext() 
            : base("WeixinDB")
        {

        }

        public DbSet<Danmu> Danmus { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<BlackValue> BlackList { get; set; }
        public DbSet<ImageStorage> ImageStorages { get; set; }
        public DbSet<Story> Story { get; set; }
        public DbSet<Faces> Faces { get; set; }
    }

    public sealed class Danmu
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string OpenId { get; set; }
        public string Content { get; set; }
        public int CreateTime { get; set; }
    }

    [Table("ImageStorages")]
    public sealed class ImageStorage
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Md5 { get; set; }
        public string OpenId { get; set; }
        public int CreateTime { get; set; }
        public string PicUrl { get; set; }
        //public byte[] PicContent { get; set; }
        public string ParsedUrl { get; set; }
        //public byte[] ParsedContent { get; set; }
        public string ParsedDescription { get; set; }
        public string TimeLog { get; set; }
    }

    [Table("Jokes")]
    public sealed class Story
    {
        public int Id { get; set; }
        public string category { get; set; }
        public string count_bury { get; set; }
        public string count_comment { get; set; }
        public string count_digg { get; set; }
        public int count_diggcomm { get; set; }
        public string count_favorite { get; set; }
        public string source { get; set; }
        public string text { get; set; }
        public string text_comment { get; set; }
    }

    [Table("Faces")]
    public sealed class Faces
    {
        public int Id { get; set; }
        public int gender { get; set; }
        public int smile { get; set; }
        public int wearingGlasses { get; set; }
        public int headPose { get; set; }
        public int age { get; set; }
        public string url { get; set; }
    }

    public sealed class Token
    {
        [Key]
        public int Id { get; set; }
        public string AccessToken { get; set; }
        public string ExpireDate { get; set; }
    }

    [Table("BlackList")]
    public class BlackValue
    {
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }
    }
}