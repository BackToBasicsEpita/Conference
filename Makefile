TEX_FILES = $(wildcard main.*)
TRASH = $(filter-out main.tex,$(TEX_FILES))

all: main.tex
	pdflatex main.tex

clean:
	$(RM) $(TRASH)
