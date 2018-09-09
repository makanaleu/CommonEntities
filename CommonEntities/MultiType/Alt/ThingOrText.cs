﻿using CommonEntities.Core;
using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Alt
{
    /// <summary>
    /// ThingOrText MultiType accepts a Thing or Text.
    /// </summary>
    /// <example>https://schema.org/requiredCollateral</example>
    [DataContract(Name = "ThingOrText", Namespace = "CommonEntities.MultiType.Alt")]
    public class ThingOrText : Text
    {
        /// <summary>
        /// ThingOrText as a Thing.
        /// </summary>
        [DataMember(Name = "asThing")]
        public Thing AsThing;

        /// <summary>
        /// ThingOrText as a Thing.
        /// </summary>
        /// <param name="thing">ThingOrText as a Thing.</param>
        public ThingOrText(Thing thing) : base(thing.Name.AsText)
        {
            AsThing = thing;
        }

        /// <summary>
        /// ThingOrText as a Text.
        /// </summary>
        /// <param name="text">ThingOrText as a Text.</param>
        public ThingOrText(Text text) : base(text.AsText)
        {
        }
    }
}
