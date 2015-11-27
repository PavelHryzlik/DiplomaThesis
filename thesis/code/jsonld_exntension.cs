// Convert value to corresponding type (reflects JSON Schema types)
// e.g. DateTime is string in JSON Schema with dateTime formatting
switch (((JValue)value["@type"]).Value.ToString())
{
    // JSON Schema type - boolean
    case XmlSpecsHelper.XmlSchemaDataTypeBoolean:
        bool boolValue;
        if (bool.TryParse(stringValue, out boolValue))
        {
            return new JValue(boolValue);
        }
        break;
    // JSON Schema type - integer
    case XmlSpecsHelper.XmlSchemaDataTypeInteger:
        int integerValue;
        if (int.TryParse(stringValue, out integerValue))
        {
            return new JValue(integerValue);
        }
        break;
    // JSON Schema type - number
    case XmlSpecsHelper.XmlSchemaDataTypeFloat:
        float floatValue;
        if (float.TryParse(stringValue, out floatValue))
        {
            return new JValue(floatValue);
        }
        break;
}
return new JValue(stringValue);