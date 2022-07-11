﻿using GenshinPray.Dao;
using GenshinPray.Models.PO;
using GenshinPray.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinPray.Service
{
    public class PrayRecordService : BaseService
    {
        private PrayRecordDao prayRecordDao;

        public PrayRecordService(PrayRecordDao prayRecordDao)
        {
            this.prayRecordDao = prayRecordDao;
        }

        public int GetPrayTimesToday(int authId)
        {
            return prayRecordDao.getPrayTimesToday(authId);
        }

        public PrayRecordPO AddPrayRecord(YSPondType pondType, int authId, string memberCode, int prayCount)
        {
            PrayRecordPO prayRecord = new PrayRecordPO();
            prayRecord.AuthId = authId;
            prayRecord.MemberCode = memberCode;
            prayRecord.PondType = pondType;
            prayRecord.PrayCount = prayCount;
            prayRecord.CreateDate = DateTime.Now;
            return prayRecordDao.Insert(prayRecord);
        }


    }
}
