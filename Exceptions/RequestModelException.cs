using System;

namespace MarsRover
{
    public class RequestModelException
    {

        public class MapSizeIsNotCorrect : SystemException { public MapSizeIsNotCorrect() : base(){} }
        public class CoordinateIsNotCorrect : SystemException { public CoordinateIsNotCorrect() : base(){} }
        public class NotValidCommand : SystemException { public NotValidCommand() : base(){} }
    } 
}
