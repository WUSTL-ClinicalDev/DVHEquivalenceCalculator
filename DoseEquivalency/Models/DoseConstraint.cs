using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTemplates
{
    
        public class DoseConstraint
        {
            /// <summary>
            /// Dose Constraint definitions.
            /// </summary>
            /// <param name="structureId">The Id of the corresponding structure.</param>
            /// <param name="constraintType">The type of Dose Constraint (ex: D, V, Mean, Min, Max).</param>
            /// <param name="constraintLevel">The level of the Dose Constraint (only applies to volume receiving dose, or dose to volume types of constraints).</param>
            /// <param name="constraintUnits"> The units of the constraint (ex: for volume type, "cc" or "%", for dose type, "cGy" or "%").</param>
            /// <param name="resultUnits"> The units of the result (ex: "cGy" or "%" for dose to a volume, "cc" or "%" for volume receiving a specific dose). </param>
            /// <param name="constraintCriteria">The criteria used to evaluate the Dose Constraint (ex: <, >, <=, >=).</param>
            /// <param name="constraintValue">The dose constraint limit.</param>
            /// /// <param name="constraintValueVariation">The variation acceptable dose constraint limit.</param>
            /// <param name="constraintPriority"> The priority of the constraint (ex: 1, 2, 3...).</param>
            public DoseConstraint(string structureId, string constraintType, double constraintLevel, string constraintUnits, string resultUnits, string constraintCriteria, double constraintValue, double constraintValueVariation, int constraintPriority, string constraintNote)
            {
                StructureId = structureId;
                Type = constraintType;
                LevelDefinition = constraintLevel;
                ConstraintUnits = constraintUnits;
                ResultUnits = resultUnits;
                EvalCriteria = constraintCriteria;
                Goal = constraintValue;
                VariationAcceptable = constraintValueVariation;
                Priority = constraintPriority;
                Note = constraintNote;
            }

            /// <summary>
            /// Gets or sets the Id of the structure to which the Dose Constraint applies.
            /// </summary>
            public string StructureId { get; set; }
            /// <summary>
            /// Gets or sets the Dose Constraint type (D, V, Mean, Min, Max).
            /// </summary>
            public string Type { get; set; }
            /// <summary>
            /// Gets or sets the Dose Constraint level parameter (only applies to volume receiving dose, or dose to volume types of constraints).
            /// </summary>
            public double LevelDefinition { get; set; }
            /// <summary>
            /// Gets or sets the units of the Dose Constraint (ex: for volume type, "cc" or "%", for dose type, "cGy" or "%")
            /// </summary>
            public string ConstraintUnits { get; set; }
            /// <summary>
            /// Gets or sets the units of the Dose Constraint result (ex: "cGy" or "%" for dose to a volume, "cc" or "%" for volume receiving a specific dose)
            /// </summary>
            public string ResultUnits { get; set; }
            /// <summary>
            /// Gets or sets the DoseConstraint Criteria (ex: <, >, <=, >=).
            /// </summary>
            public string EvalCriteria { get; set; }
            /// <summary>
            /// Gets or sets the Dose Constraint limit.
            /// </summary>
            public double Goal { get; set; }
            /// <summary>
            /// Gets or sets the Dose Constraint priority (ex: 1, 2, 3).
            /// </summary>
            public double VariationAcceptable { get; set; }
            /// <summary>
            /// Gets or sets the Dose Constraint priority (ex: 1, 2, 3).
            /// </summary>
            public int Priority { get; set; }
            /// <summary>
            /// Gets or sets the Dose Constraint note (ex: bilateral, unilateral, left-sided).
            /// </summary>
            public string Note { get; set; }

        }
    
}
