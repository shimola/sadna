﻿using DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    public class CurrentForumState
    {
        public CurrentForumState(){}
        public CurrentForumState(ForumInfo myForum, SubForumInfo currentSubForumInfo, PostInfo currentPostInfo)
        {
            this.myForum = myForum;
            this.currentSubForumInfo = currentSubForumInfo;
            this.currentPostInfo = currentPostInfo;
        }


        public ForumInfo myForum { get; set; }
        public SubForumInfo currentSubForumInfo { get; set; }
        public PostInfo currentPostInfo { get; set; }
    }
}
