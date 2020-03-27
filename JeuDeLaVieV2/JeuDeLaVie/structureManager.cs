﻿using System.Collections.Generic;

namespace JeuDeLaVie
{
    public class StructureManager
    {
        public List<StructureTemplate> StructureTemplates { get; }
        public List<StructureTemplate> StructureTemplatesNature { get; }
        public List<StructureTemplate> StructureTexture { get; }

        public StructureManager()
        {
            StructureTemplates = new List<StructureTemplate>();
            StructureTexture = new List<StructureTemplate>();
            StructureTemplatesNature = new List<StructureTemplate>();

            StructureTemplates.Add(new StructureTemplate(new byte[3, 3] {
                { 1, 1, 1 },
                { 1, 0, 0 },
                { 0, 1, 0 }},
                "V1"));
            StructureTemplates.Add(new StructureTemplate(new byte[4, 5] {
                { 0, 1, 1, 1, 1},
                { 1, 0, 0, 0, 1 },
                { 0, 0, 0, 0, 1 },
                { 1, 0, 0, 1, 0 }},
                "V2"));
            StructureTemplates.Add(new StructureTemplate(new byte[4, 6] {
                { 0, 0, 0, 1, 1, 0 },
                { 1, 1, 1, 0, 1, 1 },
                { 1, 1, 1, 1, 1, 0 },
                { 0, 1, 1, 1, 0, 0} },
                "V3"));
            StructureTemplates.Add(new StructureTemplate(new byte[4, 7] {
                { 0, 0, 0, 0, 1, 1, 0 },
                { 1, 1, 1, 1, 0, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 0 },
                { 0, 1, 1, 1, 1, 0, 0} },
                "V4"));

            const string SIR_ROBIN = "....OO.............................O..O...........................O...O............................OOO........................OO......OOOO...................O.OO....OOOO..................O....O......OOO.................OOOO....OO...O...............O.........OO....................O...O...............................OOO..OO..O.................OO.......O....O...........................O.OO........................OO......O.......................OO.OOO.O......................OO...O..O......................O.O..OO........................O..O.O.O.......................OOO......O......................O.O.O...O.........................OO.O.O......................O......OOO....................................................O.........O....................O...O......O....................O.....OOOOO....................OOO................................OO..........................OOO..O.......................O.OOO.O.......................O...O..O........................O....OO.OOO......................OOOO.O....OO...................O.OOOO....OO.........................O...............................O..OO..........................OO..............................OOOOO..............................OO.......................OOO......O......................O.O...O.O.....................O...O...O......................O...OO........................O......O.OOO....................OO...O...OO.....................OOOO..O..O.......................OO...O........................O..............................OO.O..........................O.............................OOOOO..........................O....O........................OOO.OOO........................O.OOOOO........................O................................O..........................O....OOOO..........................OOOO.OO.....................OOO....O..............................O.O................................O..........................O..OO...........................OOO.........................OO............................OOO.....O.........................OO..O.O.....................O..OOO.O.O......................OO.O..O..........................O.O..OO..........................OO.........................OOO....O.......................OOO....O........................OO...OOO........................OO.OO...........................OO.............................O............................................................OO...............................O....";
            byte[,] b = new byte[31, 79];
            for (int y = 0; y<79; y++)
            {
                for (int x = 0; x < 31; x++)
                {
                    if (SIR_ROBIN[31 * y + x] == 'O')
                    {
                        b[x, y] = 1;
                    }
                    else
                    {
                        b[x, y] = 0;
                    }
                }
            }
            StructureTemplates.Add(new StructureTemplate(b, "SR"));

            StructureTemplates.Add(new StructureTemplate(new byte[9, 36] {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1 },
                { 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }},
                "C1"));

            StructureTemplates.Add(new StructureTemplate(new byte[21, 33] {
                { 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 1},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            }, 
            "C2"));

            StructureTemplates.Add(new StructureTemplate(new byte[8, 8] {
                { 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 1, 0, 1, 0, 1, 0, 0},
                { 0, 0, 2, 2, 2, 0, 0, 0},
                { 0, 1, 2, 2, 2, 1, 0, 0},
                { 0, 0, 2, 2, 2, 0, 0, 0},
                { 0, 1, 0, 1, 0, 1, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0}
            },
            "C3"));


            StructureTexture.Add(new StructureTemplate(new byte[5, 5] {
                { 0, 1, 0, 0, 0},
                { 0, 0, 1, 0, 0},
                { 0, 0, 0, 1, 0},
                { 0, 0, 1, 0, 0},
                { 0, 1, 0, 0, 0}
            }
            , "arrow"));

            StructureTemplates.ForEach(s =>
            {
                //s.Id[0] != 'V' && s.Id[0] != 'S' && s.Id!="arrow"
                if (s.Id == "C3")
                    StructureTemplatesNature.Add(s);
            });


        }


        
    }
}
