
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using BibliothèqueLogiqueCombat.Models.Personnages;


namespace CombatWPF.Models
{


    /// <summary>
    /// Auteur: Martin Lalancette
    /// Description: Cette classe permet de sérialiser et désérialiser (JSON) des classes polymorphiques.
    /// Date: 2022-05-23
    /// </summary>
   
    public class PersonnageConverter : JsonConverter<Personnage>
    {
        /// <summary>
        /// Auteur: Martin Lalancette  
        /// Description: Cette énumération permet d'aiguiller l'opération vers la bonne classe (vice versa).  
        ///              Normalement, rien à modifier. À moins que les noms des classes diffèrent. 
        /// Date: 2022-05-23 
        /// </summary>
        private enum TypePersonnage
        {
            Personnage = 0,
            Archer = 1,
            Chevalier = 2,
            Blanc = 3,
            Noir = 4
        }

        /// <summary>
        /// Auteur: Martin Lalancette  
        /// Description: Cette méthode permet de valider si l'objet peur être converti.  
        /// Date: 2022-05-23  
        /// </summary>
        /// <param name="type">Type de l'objet</param>
        /// <returns>true = Peut être converti, false = non.</returns>
        public override bool CanConvert(Type type)
        {
            return typeof(Personnage).IsAssignableFrom(type);
        }

        /// <summary>
        /// Auteur: Martin Lalancette
        /// Description: Cette méthode permet d'indiquer comment lire les informations à partir
        ///              du fichier JSON (Désérialisation) et de créer le personnage avec la bonne 
        ///              classe dérivée.
        /// Date: 2022-05-23
        /// </summary>
        /// <param name="reader">Référence sur le fichier JSON à lire</param>
        /// <param name="typeToConvert">Type à convertir</param>
        /// <param name="options">Options possibles avec JsonSerializer</param>
        /// <returns>Personnage avec ses informations</returns>
        public override Personnage Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            if (!reader.Read()
                    || reader.TokenType != JsonTokenType.PropertyName
                    || reader.GetString() != "TypePersonnage")
            {
                throw new JsonException();
            }

            if (!reader.Read() || reader.TokenType != JsonTokenType.Number)
            {
                throw new JsonException();
            }

            Personnage personnage;
            TypePersonnage TypePersonnage = (TypePersonnage)reader.GetInt32();
            switch (TypePersonnage)
            {
                case TypePersonnage.Archer:
                    if (!reader.Read() || reader.GetString() != "Valeurs")
                    {
                        throw new JsonException();
                    }
                    if (!reader.Read() || reader.TokenType != JsonTokenType.StartObject)
                    {
                        throw new JsonException();
                    }
                    personnage = (Archer)JsonSerializer.Deserialize(ref reader, typeof(Archer));
                    break;
                case TypePersonnage.Chevalier:
                    if (!reader.Read() || reader.GetString() != "Valeurs")
                    {
                        throw new JsonException();
                    }
                    if (!reader.Read() || reader.TokenType != JsonTokenType.StartObject)
                    {
                        throw new JsonException();
                    }
                    personnage = (Chevalier)JsonSerializer.Deserialize(ref reader, typeof(Chevalier));
                    break;
                case TypePersonnage.Noir:
                    if (!reader.Read() || reader.GetString() != "Valeurs")
                    {
                        throw new JsonException();
                    }
                    if (!reader.Read() || reader.TokenType != JsonTokenType.StartObject)
                    {
                        throw new JsonException();
                    }
                    personnage = (Noir)JsonSerializer.Deserialize(ref reader, typeof(Noir));
                    break;
                case TypePersonnage.Blanc:
                    if (!reader.Read() || reader.GetString() != "Valeurs")
                    {
                        throw new JsonException();
                    }
                    if (!reader.Read() || reader.TokenType != JsonTokenType.StartObject)
                    {
                        throw new JsonException();
                    }
                    personnage = (Blanc)JsonSerializer.Deserialize(ref reader, typeof(Blanc));
                    break;
                default:
                    throw new NotSupportedException();
            }

            if (!reader.Read() || reader.TokenType != JsonTokenType.EndObject)
            {
                throw new JsonException();
            }

            return personnage;
        }

        /// <summary>
        /// Auteur: Martin Lalancette
        /// Description: Cette méthode permet d'écrire les informations d'un personnage 
        ///              dans le fichier JSON (Sérialisation).
        /// 
        ///              Exemple:
        ///              {
        ///                   "TypePersonnage": 1,
        ///                   "Valeurs": {
        ///                     "NbFl\u00E8ches": 99,
        ///                     "Nom": "Archer #1",
        ///                     "Niveau": 1,
        ///                     "Exp\u00E9rience": 200,
        ///                     "ClasseArmure": 9,
        ///                     "PointsDeVie": 17,
        ///                     "BonusAttaque": 0,
        ///                     "DommageMax": 8,
        ///                     "Victoires": 4,
        ///                     "D\u00E9faites": 3,
        ///                     "NbAttaques": 0
        ///              }
        /// </summary>
        /// <param name="writer">Référence au fichier dans lequel le json sera écrit.</param>
        /// <param name="value">L'objet à sérialiser</param>
        /// <param name="options">Options possibles avec JsonSerializer</param>
        public override void Write(
            Utf8JsonWriter writer,
            Personnage value,
            JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            if (value is Archer)
            {
                Archer archer = value as Archer;
                writer.WriteNumber("TypePersonnage", (int)TypePersonnage.Archer);
                writer.WritePropertyName("Valeurs");
                JsonSerializer.Serialize(writer, archer);
            }
            else if (value is Chevalier)
            {
                Chevalier chevalier = value as Chevalier;
                writer.WriteNumber("TypePersonnage", (int)TypePersonnage.Chevalier);
                writer.WritePropertyName("Valeurs");
                JsonSerializer.Serialize(writer, chevalier);
            }
            else if (value is Blanc)
            {
                Blanc blanc = value as Blanc;
                writer.WriteNumber("TypePersonnage", (int)TypePersonnage.Blanc);
                writer.WritePropertyName("Valeurs");
                JsonSerializer.Serialize(writer, blanc);
            }
            else if (value is Noir)
            {
                Noir noir = value as Noir;
                writer.WriteNumber("TypePersonnage", (int)TypePersonnage.Noir);
                writer.WritePropertyName("Valeurs");
                JsonSerializer.Serialize(writer, noir);
            }
            else
            {
                throw new NotSupportedException();
            }

            writer.WriteEndObject();
        }
    }
}

