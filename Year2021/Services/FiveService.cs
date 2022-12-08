using System;
using System.Collections.Generic;
using System.Linq;
using Year2021.Models;
using Year2021.Services.Interfaces;

namespace Year2021.Services
{
    public class FiveService : IFiveService
    {
        public int VentGraph(List<Line> lines)
        {
            List<Coordinates> coordinates = new();
            foreach (var line in lines)
            {
                coordinates.AddRange(GetHorizontal(line));
                coordinates.AddRange(GetVertical(line));
            }

            var total = (from coord in coordinates
                         group coord by new { coord.X, coord.Y } into coordGroup
                         select new Coordinates()
                         {
                             X = coordGroup.Key.X,
                             Y = coordGroup.Key.Y,
                             LineCount = coordGroup.Count()
                         }).ToList()
                           .Where(x => x.LineCount >= 2)
                           .Count();

            return total;
        }

        public int VentGraphDiagonal(List<Line> lines)
        {
            List<Coordinates> coordinates = new();
            foreach (var line in lines)
            {
                coordinates.AddRange(GetHorizontal(line));
                coordinates.AddRange(GetVertical(line));
                coordinates.AddRange(GetDiagonal(line));
            }

            var total = (from coord in coordinates
                         group coord by new { coord.X, coord.Y } into coordGroup
                         select new Coordinates()
                         {
                             X = coordGroup.Key.X,
                             Y = coordGroup.Key.Y,
                             LineCount = coordGroup.Count()
                         }).ToList()
                          .Where(x => x.LineCount >= 2)
                          .Count();

            return total;
        }

        //I hate this function
        private static List<Coordinates> GetDiagonal(Line line)
        {
            List<Coordinates> coordinates = new();

            if (line.BeginX != line.EndX)
            {
                var m = (line.EndY - line.BeginY) / (line.EndX - line.BeginX);
                if (line.BeginY > line.EndY && Math.Abs(m) == 1)
                {
                    int distance = line.BeginY - line.EndY;

                    if (line.BeginX > line.EndX)
                    {
                        for (var i = 0; i <= distance; i++)
                        {
                            coordinates.Add(new Coordinates()
                            {
                                X = line.BeginX - i,
                                Y = line.BeginY - i,
                            });
                        }
                    }
                    else
                    {
                        for (var i = 0; i <= distance; i++)
                        {
                            coordinates.Add(new Coordinates()
                            {
                                X = line.BeginX + i,
                                Y = line.BeginY - i,
                            });
                        }
                    }

                }
                else if (line.EndY > line.BeginY && Math.Abs(m) == 1)
                {
                    int distance = line.EndY - line.BeginY;

                    if (line.BeginX > line.EndX)
                    {
                        for (var i = 0; i <= distance; i++)
                        {
                            coordinates.Add(new Coordinates()
                            {
                                X = line.BeginX - i,
                                Y = line.BeginY + i,
                            });
                        }
                    }
                    else
                    {
                        for (var i = 0; i <= distance; i++)
                        {
                            coordinates.Add(new Coordinates()
                            {
                                X = line.BeginX + i,
                                Y = line.BeginY + i,
                            });
                        }
                    }

                }
            }
            return coordinates;
        }

        private static List<Coordinates> GetHorizontal(Line line)
        {
            List<Coordinates> coordinates = new();
            if (line.BeginX == line.EndX && line.BeginY > line.EndY)
            {
                for (var i = 0; i <= line.BeginY - line.EndY; i++)
                {
                    coordinates.Add(new Coordinates()
                    {
                        X = line.BeginX,
                        Y = line.BeginY - i,
                    });
                }
            }
            else if (line.BeginX == line.EndX && line.EndY > line.BeginY)
            {
                for (var i = 0; i <= line.EndY - line.BeginY; i++)
                {
                    coordinates.Add(new Coordinates()
                    {
                        X = line.BeginX,
                        Y = line.BeginY + i,
                    });
                }
            }
            return coordinates;
        }

        private static List<Coordinates> GetVertical(Line line)
        {
            List<Coordinates> coordinates = new();

            if (line.BeginY == line.EndY && line.BeginX > line.EndX)
            {
                for (var i = 0; i <= line.BeginX - line.EndX; i++)
                {
                    coordinates.Add(new Coordinates()
                    {
                        X = line.BeginX - i,
                        Y = line.BeginY,
                    });
                }
            }
            else if (line.BeginY == line.EndY && line.EndX > line.BeginX)
            {
                for (var i = 0; i <= line.EndX - line.BeginX; i++)
                {
                    coordinates.Add(new Coordinates()
                    {
                        X = line.BeginX + i,
                        Y = line.BeginY,
                    });
                }
            }
            return coordinates;
        }
    }

}
