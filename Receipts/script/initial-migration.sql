CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

START TRANSACTION;

CREATE TABLE "Receipts" (
    "Id" uuid NOT NULL,
    "Name" text NULL,
    "Description" text NULL,
    "ImageUrl" text NULL,
    "CreatedDate" timestamp without time zone NOT NULL,
    "ModifiedDate" timestamp without time zone NOT NULL,
    CONSTRAINT "PK_Receipts" PRIMARY KEY ("Id")
);

CREATE TABLE "IngredientRecipe" (
    "Id" uuid NOT NULL,
    "Quantity" text NULL,
    "Ingredient" text NULL,
    "RecipeId" uuid NULL,
    "ReceiptId" uuid NOT NULL,
    "CreatedDate" timestamp without time zone NOT NULL,
    "ModifiedDate" timestamp without time zone NOT NULL,
    CONSTRAINT "PK_IngredientRecipe" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_IngredientRecipe_Receipts_ReceiptId" FOREIGN KEY ("ReceiptId") REFERENCES "Receipts" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_IngredientRecipe_Receipts_RecipeId" FOREIGN KEY ("RecipeId") REFERENCES "Receipts" ("Id") ON DELETE RESTRICT
);

CREATE TABLE "StepRecipe" (
    "Id" uuid NOT NULL,
    "Step" text NULL,
    "StepNumber" integer NOT NULL,
    "RecipeId1" uuid NULL,
    "RecipeId" uuid NOT NULL,
    "CreatedDate" timestamp without time zone NOT NULL,
    "ModifiedDate" timestamp without time zone NOT NULL,
    CONSTRAINT "PK_StepRecipe" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_StepRecipe_Receipts_RecipeId" FOREIGN KEY ("RecipeId") REFERENCES "Receipts" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_StepRecipe_Receipts_RecipeId1" FOREIGN KEY ("RecipeId1") REFERENCES "Receipts" ("Id") ON DELETE RESTRICT
);

CREATE INDEX "IX_IngredientRecipe_ReceiptId" ON "IngredientRecipe" ("ReceiptId");

CREATE INDEX "IX_IngredientRecipe_RecipeId" ON "IngredientRecipe" ("RecipeId");

CREATE INDEX "IX_StepRecipe_RecipeId" ON "StepRecipe" ("RecipeId");

CREATE INDEX "IX_StepRecipe_RecipeId1" ON "StepRecipe" ("RecipeId1");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20210313193344_InitialCreate', '5.0.1');

COMMIT;