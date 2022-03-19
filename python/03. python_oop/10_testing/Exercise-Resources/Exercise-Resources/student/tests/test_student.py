from project.student import Student
from unittest import TestCase, main


class TestStudent(TestCase, main):
    def setUp(self):
        self.student = Student("Pesho")

    def test_is_initialising_correctly(self):
        student = Student("Pesho")

        self.assertEqual(student.name, "Pesho")
        self.assertEqual(student.courses, {})

    def test_is_initialising_correctly_with_course(self):
        student = Student("Pesho", {"Python": ["note1"]})

        self.assertEqual(student.name, "Pesho")
        self.assertEqual(student.courses, {"Python": ["note1"]})

    def test_init_none_course(self):
        student = Student("Pesho", None)

        self.assertEqual(student.name, "Pesho")
        self.assertEqual(student.courses, {})

    def test_enroll_duplicate_course(self):
        self.student.courses = {"Python": ["note1"]}
        res = self.student.enroll("Python", ["note2"])

        self.assertEqual(res, "Course already added. Notes have been updated.")
        self.assertEqual(["note1", "note2"], self.student.courses["Python"])

    def test_enroll_new_course_with_notes(self):
        res = self.student.enroll("Python", ["note1"])

        self.assertEqual(res, "Course and course notes have been added.")
        self.assertEqual(self.student.courses["Python"], ["note1"])

    def test_enroll_new_course_without_adding_notes(self):
        res = self.student.enroll("Python", ["note1"], "no")

        self.assertEqual(res, "Course has been added.")
        self.assertEqual(self.student.courses["Python"], [])

    def test_enroll_new_course_with_adding_notes(self):
        res = self.student.enroll("Python", ["note1"], "Y")

        self.assertEqual(res, "Course and course notes have been added.")
        self.assertEqual(self.student.courses["Python"], ["note1"])

    def test_enroll_in_existing_course_with_adding_notes(self):
        self.student.enroll("Python", ["note1", "note2"], 'Y')
        res = self.student.enroll("Python", ["note3"], 'Y')

        self.assertEqual(res, "Course already added. Notes have been updated.")
        self.assertEqual(self.student.courses["Python"], ["note1", "note2", "note3"])

    def test_add_notes(self):
        self.student.courses = {"Python": []}
        res = self.student.add_notes("Python", "note1")

        self.assertEqual( "Notes have been updated", res)
        self.assertEqual(["note1"], self.student.courses["Python"])

    def test_add_notes_exception(self):
        with self.assertRaises(Exception) as ex:
            self.student.add_notes("Java", "note_fail")

        self.assertEqual(str(ex.exception), "Cannot add notes. Course not found.")
        self.assertEqual(self.student.courses, {})

    def test_leave_course(self):
        self.student.courses = {"Python": []}
        res = self.student.leave_course("Python")

        self.assertEqual(res, "Course has been removed")
        self.assertEqual(self.student.courses, {})

    def test_leave_course_exception(self):
        with self.assertRaises(Exception) as ex:
            self.student.courses("Java")

        self.assertEqual(str(ex.exception), "Cannot remove course. Course not found.")

if __name__ == "__main__":
    main()