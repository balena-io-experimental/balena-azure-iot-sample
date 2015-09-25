
add_executable(httpheaders_unittests httpheaders_unittests.cpp main.c)


target_include_directories(httpheaders_unittests PUBLIC ${TEST_INCLUDES} ${COMMON_SRC})
target_link_libraries (httpheaders_unittests ${CMAKE_THREAD_LIBS_INIT} ctest micromock common)
