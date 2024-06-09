using FortuneTeller.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FortuneTeller.Models
{
    public class User
    {


        [Required]
        [StringLength(50)]
        private string firstName { get; set; } = null!;

        [Required]
        [StringLength(50)]
        private string lastName { get; set; } = null!;
        [Required]
        [Range(0, 130)]
        private int age;
        [Required]
        [Range(1, 12)]
        private int birthMonth;
        [Required]
        [Range(0, 13)]
        private int sibling;

        [Required]
        private ROYGBIVEnum favoriteColor;

        public User() {
            firstName = "John";
            lastName = "Smith";
        }
        public User(string firstName, string lastName, int age, int birthMonth, int sibling, ROYGBIVEnum FavoriteColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.birthMonth = birthMonth;
            this.sibling = sibling;
            favoriteColor = FavoriteColor;
        }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get => this.firstName; set => this.firstName = UserValidation.ValidateFirstName(value); }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get => this.lastName; set => this.lastName = UserValidation.ValidateLastName(value); }

        public int Age { get => this.age; set => this.age = value; }
        public int BirthMonth { get => this.birthMonth; set => this.birthMonth = value; }
        public int Sibling { get => this.sibling; set => this.sibling = value; }

        public ROYGBIVEnum FavoriteColor { get => this.favoriteColor; set => this.favoriteColor = value; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
