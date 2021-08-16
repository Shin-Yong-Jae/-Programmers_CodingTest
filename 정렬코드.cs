//등급순 정렬
        public void GradeSortList()
        {
            List<GettedUnitUI> grade0 = new List<GettedUnitUI>();
            List<GettedUnitUI> grade1 = new List<GettedUnitUI>();
            List<GettedUnitUI> grade2 = new List<GettedUnitUI>();
            List<GettedUnitUI> grade3 = new List<GettedUnitUI>();

            for(int i=0; i<listGettedDice.Count; i++)
            {
                if (listGettedDice[i].tankUIData.grade == 0) grade0.Add(listGettedDice[i]);
                else if (listGettedDice[i].tankUIData.grade == 1) grade1.Add(listGettedDice[i]);
                else if (listGettedDice[i].tankUIData.grade == 2) grade2.Add(listGettedDice[i]);
                else grade3.Add(listGettedDice[i]);
            }

            listGettedDice.Clear();

            List<GettedUnitUI> gettedsortList = new List<GettedUnitUI>();

            gettedsortList.AddRange(grade0);
            gettedsortList.AddRange(grade1);
            gettedsortList.AddRange(grade2);
            gettedsortList.AddRange(grade3);

            for(int i=0; i<gettedsortList.Count; i++)
            {
                listGettedDice.Add(gettedsortList[i]);
                listGettedDice[i].transform.SetAsLastSibling();
            }

        }

        //등급순 역정렬
        public void ReverseGradeSortList()
        { 
            List<GettedUnitUI> grade0 = new List<GettedUnitUI>();
            List<GettedUnitUI> grade1 = new List<GettedUnitUI>();
            List<GettedUnitUI> grade2 = new List<GettedUnitUI>();
            List<GettedUnitUI> grade3 = new List<GettedUnitUI>();

            for(int i=0; i< listGettedDice.Count; i++)
            {
                if (listGettedDice[i].tankUIData.grade == 0) grade0.Add(listGettedDice[i]);
                else if (listGettedDice[i].tankUIData.grade == 1) grade1.Add(listGettedDice[i]);
                else if (listGettedDice[i].tankUIData.grade == 2) grade2.Add(listGettedDice[i]);
                else grade3.Add(listGettedDice[i]);
            }

            listGettedDice.Clear();

            List<GettedUnitUI> reversegettedList = new List<GettedUnitUI>();

            reversegettedList.AddRange(grade3);
            reversegettedList.AddRange(grade2);
            reversegettedList.AddRange(grade1);
            reversegettedList.AddRange(grade0);

            for(int i=0; i<reversegettedList.Count; i++)
            {
                listGettedDice.Add(reversegettedList[i]);
                listGettedDice[i].transform.SetAsLastSibling();
            }
        }

        public class LevelSort
        {
            public int Name { get; set; }
            public int Level { get; set; }

            public LevelSort(int name, int level)
            {
                Name = name;
                Level = level;
            }
        }

        //레벨순 정렬
        public void UpdateDiceListByLevel()
        {
            List<LevelSort> list = new List<LevelSort>();

            for(int i=0; i<listGettedDice.Count; i++)
            {
                list.Add(new LevelSort(listGettedDice[i].tankUIData.id, listGettedDice[i].tankUIData.level));
            }

            list.Sort(delegate (LevelSort x, LevelSort y)
            {
                return y.Level.CompareTo(x.Level);
            });

            List<GettedUnitUI> sortByLevel = new List<GettedUnitUI>();

            for(int i=0; i<list.Count; i++)
            {
                sortByLevel.Add(listGettedDice.Find(x => x.tankUIData.id == list[i].Name));
                sortByLevel[i].transform.SetAsLastSibling();
            }
        }