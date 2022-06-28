using UnityEngine;

public static class MathHelper
{
    public static float GetDistance(Transform target, Transform self)
    {
        if (target != null)
        {
            return Vector3.Distance(self.position, target.position);
        }
        else
        {
            return 1000f;
        }
        
    }
    public static float GetDistance2D(Transform target, Transform self)
    {
        if (target != null)
        {
            Vector2 pos1 = new Vector2(target.position.x, target.position.z);
            Vector2 pos2 = new Vector2(self.position.x, self.position.z);

            return Vector2.Distance(pos1, pos2);
        }
        else
        {
            return 1000f;
        }
    }
    public static float GetDistance2D(Vector3 target, Transform self)
    {
        if (target != null)
        {
            Vector2 pos1 = new Vector2(target.x, target.z);
            Vector2 pos2 = new Vector2(self.position.x, self.position.z);

            return Vector2.Distance(pos1, pos2);
        }
        else
        {
            return 1000f;
        }
    }

    public static float GetAngle(Transform target, Transform self)
    {
        Vector3 _pos1 = self.position;
        _pos1.y = 0;
        Vector3 _pos2 = target.position;
        _pos2.y = 0;

        Vector3 rayDirection = _pos2 - _pos1;

        float _angle = Vector3.Angle(rayDirection, self.forward);

        Debug.Log("Angle " + _angle);
        return _angle;
    }
    public static float GetAngle2D(Transform target, Transform self)
    {
        Vector2 _pos1 = new Vector2(target.position.x, target.position.z);
        Vector2 _pos2 = new Vector2(self.position.x, self.position.z);

        Vector2 _rayDirection = _pos2 - _pos1;

        float _angle = Vector2.Angle(_rayDirection, self.forward);


        //Debug.Log("Angle 2D" + _angle);
        return _angle;
    }

    public static Vector3 PositionAroundObject(Transform transform, float radius)
    {
        Vector2 random = Random.insideUnitCircle.normalized * radius;
        Vector3 position = transform.position + new Vector3(random.x, .2f, random.y);

        return position;
    }


    public static float GetValueByModifier(float baseValue, float modifier, int level, ModifierType modType)
    {
        float value = 0;

        switch (modType)
        {
            case ModifierType.BASE_x_pow_MOD_LVL:
                value = baseValue * Mathf.Pow(modifier, level);
                break;
            case ModifierType.BASE_x_LVL_x_pow_MOD_LVL:
                value = baseValue * level * Mathf.Pow(modifier, level);
                break;
            case ModifierType.BASE_plus_BASE_x_pow_MOD_LVL:
                value = baseValue + baseValue * Mathf.Pow(modifier, level);
                break;
        }


        return value;
    }

}

public enum ModifierType
{
    BASE_x_pow_MOD_LVL,
    BASE_x_LVL_x_pow_MOD_LVL,
    BASE_plus_BASE_x_pow_MOD_LVL
}
