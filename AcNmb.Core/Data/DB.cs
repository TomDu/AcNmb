using AcNmb.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcNmb.Core.Data
{
    public static class DB
    {
        private static List<string> forumIdList = new List<string>() {
            "4", "20", "11", "30", "32", "40", "35", "56", "103", "17", "98",
            "102", "97", "89", "27", "81", "106", "104", "14", "12", "99", "90", "87", "19", "64", "6", "5",
            "93", "101", "2", "73", "72", "86", "22", "70", "107", "108", "95", "10", "34", "51", "44", "23",
            "45", "80", "28", "38", "29", "24", "25", "92", "16", "100", "13", "55", "39", "31",
            "54", "33", "37", "75", "88", "18"
        };

        private static List<string> ForumNameList = new List<string>() {
            "综合版1", "欢乐恶搞", "推理", "技术宅", "料理", "貓版", "音乐", "考试", "文学",
            "二次创作", "姐妹1", "女性向", "女装", "日记", "WIKI", "都市怪谈", "买买买", "活动", "动画", "漫画", "国漫",
            "美漫", "轻小说", "小说", "GALGAME", "VOCALOID", "东方Project", "舰娘", "LoveLive",
            "游戏", "EVE", "DNF", "战争雷霆", "LOL", "DOTA", "Steam", "辐射", "GTA5", "Minecraft", "MUG", "WOT",
            "WOW", "D3", "卡牌桌游", "炉石传说", "怪物猎人", "口袋妖怪", "AC大逃杀", "索尼", "任天堂",
            "日麻", "AKB", "SNH48", "COSPLAY", "声优", "模型", "影视", "摄影", "体育", "军武",
            "数码", "天台", "值班室"
        };

        public static List<Forum> ForumList;

        static DB()
        {
            ForumList = new List<Forum>();
            for(int i = 0; i < forumIdList.Count; ++i)
            {
                ForumList.Add(new Forum
                {
                    Id = forumIdList[i],
                    Name = ForumNameList[i]
                });
            }
        }
    }
}
