//Let us understand the Logic first
//Find the layer, layer means inside rotation
//study the pattern
//for minimum of M X N

| Min | Layer
| 2   |  0
| 4   |  1
| 6   |  2     and so on

so layer = (Min(M,N) / 2)  - 1 (as we have this constraint, (minimum will always be even number) so min / 2 -1 = layer)

follow traversal logic like :

move and increase row..reached max value of row?
move column and increase ----reached max value of column?
move row and decarease----reached min value of row?
move column decrease and ---reached min value of column?

now walk according to R and keep these constraints in mind




int rows,cols,rot;
    scanf("%d%d%d",&rows,&cols,&rot);
    int arr[rows][cols];
    int result[rows][cols];
    for (int r = 0; r < rows; r++) {
        for (int c = 0; c < cols; c++) {
            scanf("%d", &arr[r][c]);
        }
    }

    rows--;
    cols--;
    for (int r = 0; r <= rows; r++) {
        for (int c = 0; c <= cols; c++) {
            int x = r < rows - r ? r : rows - r;
            int y = c < cols - c ? c : cols - c;
            int min = x < y ? x : y;
            int maxRow = rows - min;
            int maxCol = cols - min;
            int parameter = (maxRow + maxCol) * 2 - min * 4;

            int row = r;
            int col = c;
            for (int a = 0; a < rot%parameter; a++) {
                if (col == min && row < maxRow) {
                    row++;
                }
                else if (row == maxRow && col < maxCol) {
                    col++;
                }
                else if (row > min && col == maxCol) {
                    row--;
                }
                else if (row == min && col > min) {
                    col--;
                }
            }
            result[row][col] = arr[r][c];
        }
    }


    for (int r = 0; r <= rows; r++) {
        for (int c = 0; c <= cols; c++) {
            printf("%d ", result[r][c]);
        }
        printf("\n");
    }


    return 0;
