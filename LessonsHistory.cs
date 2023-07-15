using System;
using System.Collections.Generic;

namespace MyNameSpace
{
    public class LessonHistory
    {
        private static List<LessonEntry> lessons;

        public LessonHistory()
        {
            if (lessons == null)
            {
                lessons = new List<LessonEntry>();
            }
        }

        public void AddLesson(string lessonName)
        {
            LessonEntry entry = new LessonEntry
            {
                LessonName = lessonName,
                DateTime = DateTime.Now
            };

            lessons.Add(entry);
        }

        public List<LessonEntry> GetLessons()
        {
            return lessons;
        }

        public bool IsEmpty()
        {
            return lessons.Count == 0;
        }
    }

    public class LessonEntry
    {
        public string LessonName { get; set; }
        public DateTime DateTime { get; set; }
    }
}
