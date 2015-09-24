<?xml version="1.0" encoding="utf-8"?>
<!--<?xml-stylesheet type="text/xsl" href="StudentsStyle.xslt"?>-->

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <html>
      <body>
        <h1>Students</h1>
        <table bgcolor="#E0E0E0" cellspacing="1" border="1" >
          <tr bgcolor="#EEEEEE">
            <td>
              <b>Student name</b>
            </td>
            <td>
              <b>Sex</b>
            </td>
            <td>
              <b>Birth date</b>
            </td>
            <td>
              <b>Phone</b>
            </td>
            <td>
              <b>Email</b>
            </td>
            <td>
              <b>Course</b>
            </td>
            <td>
              <b>Speciality</b>
            </td>
            <td>
              <b>Faculty num</b>
            </td>
            <td>
              <b>Exams</b>
              <td>Name</td>
              <td>Tutor</td>
              <td>Score</td>
            </td>
          </tr>

          <xsl:for-each select="students/student">
            <tr bgcolour="white">
              <td>
                <xsl:value-of select="name"/>
              </td>
              <td>
                <xsl:value-of select="sex"/>
              </td>
              <td>
                <xsl:value-of select="birthdate"/>
              </td>
              <td>
                <xsl:value-of select="phone"/>
              </td>
              <td>
                <xsl:value-of select="email"/>
              </td>
              <td>
                <xsl:value-of select="course"/>
              </td>
              <td>
                <xsl:value-of select="specialty"/>
              </td>
              <td>
                <xsl:value-of select="facultynumber"/>
              </td>
              <td>
                <xsl:for-each select="takenexams">
                  <td>
                    <xsl:value-of select="name"/>
                  </td>
                  <td>
                    <xsl:value-of select="tutor"/>
                  </td>
                  <td>
                    <xsl:value-of select="score"/>
                  </td>
                </xsl:for-each>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
