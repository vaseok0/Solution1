using System;

namespace Fitness.BL.Model
{
    /// <summary>
    /// Пользователь
    /// </summary>
        [Serializable]
    public class User
    {
        #region Cвойства
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Пол.
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// День рождение.
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// Вес
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Рост
        /// </summary>
        public double Height { get; set; }

        public int Age { get { return DateTime.Now.Year - BirthDate.Year; } }

        #endregion

        /// <summary>
        /// Создать нового пользователя.
        /// </summary>
        /// <param name="name"> Имя. </param>
        /// <param name="gender"> Пол. </param>
        /// <param name="birthDate"> Дата рождения. </param>
        /// <param name="weight"> Вес. </param>
        /// <param name="height"> Рост. </param>
        public User(string name,
                    Gender gender,
                    DateTime birthDate, 
                    double weight, 
                    double height)
        {
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может бить пусти", nameof(name));
            }

            if(gender == null)
            {
                throw new ArgumentNullException("Пол не может бить налл", nameof(name));
            }
            if(birthDate <= DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentNullException("Невозможная дата рождения", nameof(name));
            }

            if (weight <= 0)
            {
                throw new ArgumentNullException("Вес не может бить менше 0", nameof(name));
            }

            if(height <= 0)
            {
                throw new ArgumentNullException("Рост не может бить 0", nameof(name));
            }
            #endregion

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;

        }

        public User(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может бить пустим", nameof(name));
            }

            Name = name;
        }
        public override string ToString()
        {
            return Name + " " + Age;
        }
    }
}
