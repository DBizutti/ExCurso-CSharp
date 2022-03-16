namespace _71._1___ExVetores {
    class Studant {
        public string Name { get; set; }
        public string Email { get; set; }

        public Studant() {
        }

        public Studant(string name, string email) {
            Name = name;
            Email = email;
        }

        public override string ToString() {
            return $"{Name}, {Email}";
        }
    }
}
